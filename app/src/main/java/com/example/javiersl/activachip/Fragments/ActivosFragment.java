package com.example.javiersl.activachip.Fragments;

import android.app.DatePickerDialog;
import android.app.ProgressDialog;
import android.os.Bundle;
import android.support.annotation.Nullable;
import android.support.v4.app.Fragment;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.DatePicker;
import android.widget.ListView;
import android.widget.TextView;
import android.widget.Toast;

import com.android.volley.Request;
import com.android.volley.RequestQueue;
import com.android.volley.Response;
import com.android.volley.VolleyError;
import com.android.volley.toolbox.JsonArrayRequest;
import com.android.volley.toolbox.Volley;
import com.example.javiersl.activachip.Adapters.ActivadoAdapter;
import com.example.javiersl.activachip.R;
import com.example.javiersl.activachip.Resources.Basic;

import org.json.JSONArray;

import java.util.Calendar;

/**
 * Created by JavierSL on 26/12/2017.
 */

public class ActivosFragment extends Fragment implements Basic, Response.Listener<JSONArray>, Response.ErrorListener, View.OnClickListener
{
    private ListView listView;
    private TextView txtFechaInicial, txtFechaFinal;
    private Button btConsultar;
    private ProgressDialog progressDialog;
    private static final String LLAVE = "USUARIO_ID";
    private static String usuario_id;
    private int diaI, mesI, anoI, diaF, mesF, anoF;

    //Referencia a un objeto guardando un elemento
    public static ActivosFragment newInstance(String id)
    {
        ActivosFragment fragment = new ActivosFragment();
        Bundle bundle = new Bundle();
        bundle.putString(LLAVE, id);
        fragment.setArguments(bundle);
        return fragment;
    }

    //Cuando se crea el fragmento
    @Override
    public void onCreate(@Nullable Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);

        //Compara si hay un elemento guardado
        if (getArguments() != null)
            usuario_id = getArguments().getString(LLAVE);
    }

    @Nullable
    @Override
    public View onCreateView(LayoutInflater inflater, @Nullable ViewGroup container, @Nullable Bundle savedInstanceState)
    {
        return inflater.inflate(R.layout.fragment_activos, container, false);
    }

    @Override
    public void onViewCreated(View view, @Nullable Bundle savedInstanceState)
    {
        super.onViewCreated(view, savedInstanceState);

        listView = (ListView)view.findViewById(R.id.listView);
        txtFechaInicial = (TextView)view.findViewById(R.id.txtFechaInicial);
        txtFechaFinal = (TextView)view.findViewById(R.id.txtFechaFinal);
        btConsultar = (Button)view.findViewById(R.id.btConsultar);

        //Evento click
        btConsultar.setOnClickListener(this);
        txtFechaInicial.setOnClickListener(this);
        txtFechaFinal.setOnClickListener(this);

        //Coloca la fecha por defecto
        Calendar calendar = Calendar.getInstance();
        diaI = calendar.get(Calendar.DATE);
        mesI = calendar.get(Calendar.MONTH) + 1;
        anoI = calendar.get(Calendar.YEAR);
        diaF = diaI;
        mesF = mesI;
        anoF = anoI;
        String fechaActual = String.valueOf(diaI) + "/" + String.valueOf(mesI) + "/" + String.valueOf(anoI);
        txtFechaInicial.setText(fechaActual);
        txtFechaFinal.setText(fechaActual);
    }

    @Override
    public void onResponse(JSONArray response)
    {
        progressDialog.hide();

        ActivadoAdapter adapter = new ActivadoAdapter(getContext(), response);
        listView.setAdapter(adapter);
    }

    @Override
    public void onErrorResponse(VolleyError error)
    {
        progressDialog.hide();
        Toast.makeText(getContext(), "Error en el WebService", Toast.LENGTH_SHORT).show();
    }

    //Cuando se da click sobre un elemento
    @Override
    public void onClick(View v)
    {
        switch (v.getId())
        {
            case R.id.txtFechaInicial:
                DatePickerDialog dateInicial = new DatePickerDialog(getContext(), new DatePickerDialog.OnDateSetListener()
                {
                    //Cuando se elige una fecha
                    @Override
                    public void onDateSet(DatePicker view, int year, int month, int dayOfMonth)
                    {
                        String fecha = String.valueOf(dayOfMonth) + "/" + String.valueOf(month + 1) + "/" + String.valueOf(year);
                        diaI = dayOfMonth;
                        mesI = month + 1;
                        anoI = year;

                        txtFechaInicial.setText(fecha);
                    }
                }, anoI, mesI - 1, diaI);
                dateInicial.show();
                break;

            case R.id.txtFechaFinal:
                DatePickerDialog dateFinal = new DatePickerDialog(getContext(), new DatePickerDialog.OnDateSetListener()
                {
                    //Cuando se elige una fecha
                    @Override
                    public void onDateSet(DatePicker view, int year, int month, int dayOfMonth)
                    {
                        String fecha = String.valueOf(dayOfMonth) + "/" + String.valueOf(month + 1) + "/" + String.valueOf(year);
                        diaF = dayOfMonth;
                        mesF = month + 1;
                        anoF = year;

                        txtFechaFinal.setText(fecha);
                    }
                }, anoF, mesF - 1, diaF);
                dateFinal.show();
                break;

            case R.id.btConsultar:
                consultaWebService();
                break;

            default:
                break;
        }
    }

    //Consulta al presionar el botón
    private void consultaWebService()
    {
        //Coloca el dialogo de carga
        progressDialog = new ProgressDialog(getContext());
        progressDialog.setTitle("En Proceso");
        progressDialog.setMessage("Un momento...");
        progressDialog.setProgressStyle(ProgressDialog.STYLE_SPINNER);
        progressDialog.show();

        //Inicia la peticion
        RequestQueue queue = Volley.newRequestQueue(getContext());
        String consulta = "SELECT n.digitos, a.cantidad, c.nombre, a.fecha FROM activado a, numero n, carrier c WHERE a.numero_id = n.id " +
                "AND c.id = n.carrier_id AND cliente_id = " + usuario_id;
        String horas = String.format(" AND a.fecha >= '%d-%d-%d 00:00:00' AND a.fecha <= '%d-%d-%d 23:23:59' ORDER BY a.fecha DESC;",
                anoI, mesI, diaI, anoF, mesF, diaF);
        consulta += horas;
        consulta = consulta.replace(" ", "%20");
        String cadena = "?host=" + HOST + "&db=" + DB + "&usuario=" + USER + "&pass=" + PASS + "&consulta=" + consulta;
        String url = SERVER + RUTA + "consultaGeneral.php" + cadena;
        Log.i("info", url);

        //Hace la petición String
        JsonArrayRequest request = new JsonArrayRequest(Request.Method.GET, url, null, this, this);

        //Agrega y ejecuta la cola
        queue.add(request);
    }
}
