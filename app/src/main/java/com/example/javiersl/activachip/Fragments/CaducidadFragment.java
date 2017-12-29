package com.example.javiersl.activachip.Fragments;

import android.app.ProgressDialog;
import android.os.Bundle;
import android.support.annotation.Nullable;
import android.support.v4.app.Fragment;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ListView;
import android.widget.Toast;

import com.android.volley.Request;
import com.android.volley.RequestQueue;
import com.android.volley.Response;
import com.android.volley.VolleyError;
import com.android.volley.toolbox.JsonArrayRequest;
import com.android.volley.toolbox.Volley;
import com.example.javiersl.activachip.Adapters.CaducidadAdapter;
import com.example.javiersl.activachip.R;
import com.example.javiersl.activachip.Resources.Basic;

import org.json.JSONArray;

/**
 * Created by JavierSL on 28/12/2017.
 */

public class CaducidadFragment extends Fragment implements Basic, Response.Listener<JSONArray>, Response.ErrorListener
{
    private ListView listView;
    private ProgressDialog progressDialog;
    private static final String LLAVE = "USUARIO_ID";
    private static String usuario_id;

    //Referencia el fragmento
    public static CaducidadFragment newInstance(String id)
    {
        CaducidadFragment fragment = new CaducidadFragment();
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

        if (getArguments() != null)
            usuario_id = getArguments().getString(LLAVE);
    }

    //Infla el elemento necesario
    @Nullable
    @Override
    public View onCreateView(LayoutInflater inflater, @Nullable ViewGroup container, @Nullable Bundle savedInstanceState)
    {
        return inflater.inflate(R.layout.fragment_caducidad, container, false);
    }

    @Override
    public void onViewCreated(View view, @Nullable Bundle savedInstanceState)
    {
        super.onViewCreated(view, savedInstanceState);

        listView = (ListView)view.findViewById(R.id.listView);

        progressDialog = new ProgressDialog(getContext());
        progressDialog.setTitle("En Proceso");
        progressDialog.setMessage("Un momento...");
        progressDialog.setProgressStyle(ProgressDialog.STYLE_SPINNER);
        progressDialog.show();

        //Inicia la peticion
        RequestQueue queue = Volley.newRequestQueue(getContext());
        String consulta = "SELECT nu.digitos, 29-DATEDIFF(now(),nu.fecha) AS caducidad, ca.nombre, nu.fecha FROM numero nu, carrier ca, cliente cl " +
                " WHERE nu.id NOT IN(SELECT numero_id from activado) AND nu.carrier_id = ca.id AND nu.cliente_id = cl.id AND cl.id = " + usuario_id +
                " AND ca.nombre != 'TELCEL' AND 29 >= DATEDIFF(now(),nu.fecha) ORDER BY caducidad ASC;";
        consulta = consulta.replace(" ", "%20");
        String cadena = "?host=" + HOST + "&db=" + DB + "&usuario=" + USER + "&pass=" + PASS + "&consulta=" + consulta;
        String url = SERVER + RUTA + "consultaGeneral.php" + cadena;
        Log.i("info", url);

        //Hace la petición String
        JsonArrayRequest request = new JsonArrayRequest(Request.Method.GET, url, null, this, this);

        //Agrega y ejecuta la cola
        queue.add(request);
    }

    //La respuesta del WebService
    @Override
    public void onResponse(JSONArray response)
    {
        progressDialog.hide();

        CaducidadAdapter adapter = new CaducidadAdapter(getContext(), response);
        listView.setAdapter(adapter);
    }

    //Cuando hay error en el webservice
    @Override
    public void onErrorResponse(VolleyError error)
    {
        progressDialog.hide();
        Toast.makeText(getContext(), "Error en el WebService", Toast.LENGTH_SHORT).show();
    }
}
