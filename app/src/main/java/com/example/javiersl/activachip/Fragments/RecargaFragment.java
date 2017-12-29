package com.example.javiersl.activachip.Fragments;

import android.app.ProgressDialog;
import android.content.Context;
import android.net.Uri;
import android.os.Bundle;
import android.support.annotation.NonNull;
import android.support.annotation.Nullable;
import android.support.v4.app.Fragment;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import com.android.volley.NetworkResponse;
import com.android.volley.Request;
import com.android.volley.RequestQueue;
import com.android.volley.Response;
import com.android.volley.VolleyError;
import com.android.volley.toolbox.JsonArrayRequest;
import com.android.volley.toolbox.JsonObjectRequest;
import com.android.volley.toolbox.JsonRequest;
import com.android.volley.toolbox.StringRequest;
import com.android.volley.toolbox.Volley;
import com.example.javiersl.activachip.R;
import com.example.javiersl.activachip.Resources.Basic;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

public class RecargaFragment extends Fragment implements Basic, View.OnClickListener, Response.Listener<JSONObject>,
        Response.ErrorListener
{
    private static final String LLAVE_USUARIO = "USUARIO_ID";
    private static String usuario_id;
    private EditText edtNumero, edtRepetirNumero;
    private ProgressDialog progressDialog;

    //Instancia el propio fragmento para poder guardar el id
    public static RecargaFragment newInstance(String id)
    {
        RecargaFragment fragment = new RecargaFragment();
        Bundle args = new Bundle();
        args.putString(LLAVE_USUARIO, id);
        fragment.setArguments(args);
        return fragment;
    }

    //Cuando se crea el fragmento
    @Override
    public void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);

        //Compara si hay un elemento guardado
        if (getArguments() != null)
            usuario_id = getArguments().getString(LLAVE_USUARIO);
    }

    //Cuando se crea la vista
    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
    {
        // Inflate the layout for this fragment
        return inflater.inflate(R.layout.fragment_recarga, container, false);
    }

    //Cuando la vista se creo
    @Override
    public void onViewCreated(View view, @Nullable Bundle savedInstanceState)
    {
        super.onViewCreated(view, savedInstanceState);

        //Referencia los view
        edtNumero = (EditText)view.findViewById(R.id.edtNumero);
        edtRepetirNumero = (EditText)view.findViewById(R.id.edtRepetirNumero);
        Button recarga = (Button)view.findViewById(R.id.btRecarga);

        recarga.setOnClickListener(this);
    }

    //Método cuando se presiona un elemento del fragmento
    @Override
    public void onClick(View v)
    {
        switch (v.getId())
        {
            //Cuando se presiona el botón de recarga
            case R.id.btRecarga:

                //Checa si los numeros son iguales
                if (checarNumeros(edtNumero.getText().toString(), edtRepetirNumero.getText().toString()))
                {
                    //Coloca el dialogo de carga
                    progressDialog = new ProgressDialog(getContext());
                    progressDialog.setTitle("En Proceso");
                    progressDialog.setMessage("Un momento...");
                    progressDialog.setProgressStyle(ProgressDialog.STYLE_SPINNER);
                    progressDialog.show();

                    //Inicia la peticion
                    RequestQueue queue = Volley.newRequestQueue(getContext());
                    String cadena = "?numero=" + edtNumero.getText().toString() + "&tipo=" + TIPO_CLIENTE + "&usuario_id=" +
                            usuario_id;
                    String url = SERVER + RUTA + "recarga/procesoRecarga.php" + cadena;
                    Log.i("info", url);

                    //Hace la petición String
                    JsonObjectRequest request = new JsonObjectRequest(Request.Method.PUT, url, null, this, this);

                    //Agrega y ejecuta la cola
                    queue.add(request);
                }
                else
                    Toast.makeText(getContext(), "Numeros no iguales", Toast.LENGTH_SHORT).show();
                break;

            default:
                break;
        }
    }

    //Checa si dos cadenas son iguales
    private boolean checarNumeros(String numero, String repetirNumero)
    {
        if (numero.length() == 0)
            return false;

        if (numero.equals(repetirNumero))
            return true;
        else
            return false;
    }

    //Método cuando se recibe la respuesta del webservice
    @Override
    public void onResponse(JSONObject response)
    {
        //Oculta el mensaje de progreso
        progressDialog.hide();

        try
        {
            AlertaFragment.newInstance(!response.getString("estado").equals("0"), response.getString("mensaje"))
                    .show(getFragmentManager(), "Dialogo");
        }catch (JSONException e)
        {
            Toast.makeText(getContext(), "Error al convertir JSON", Toast.LENGTH_SHORT).show();
        }
    }

    //Método cuando hay un error en el webservice
    @Override
    public void onErrorResponse(VolleyError error)
    {
        //Oculta el mensaje de progreso
        progressDialog.hide();
        Log.i("error", error.getMessage());
        Toast.makeText(getContext(), "Error al conectarse al WebService", Toast.LENGTH_SHORT).show();
    }
}
