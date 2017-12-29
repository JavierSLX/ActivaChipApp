package com.example.javiersl.activachip.Fragments;

import android.os.Bundle;
import android.support.annotation.Nullable;
import android.support.v4.app.Fragment;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ListView;

import com.android.volley.Response;
import com.android.volley.VolleyError;
import com.example.javiersl.activachip.R;
import com.example.javiersl.activachip.Resources.Basic;

import org.json.JSONArray;

/**
 * Created by JavierSL on 28/12/2017.
 */

public class ConsultaFragment extends Fragment implements Basic, View.OnClickListener, Response.Listener<JSONArray>, Response.ErrorListener
{
    private static final String LLAVE = "USUARIO_ID";
    private static String usuario_id;
    private EditText edtNumero;
    private Button btConsulta;
    private ListView listView;

    public static ConsultaFragment newInstance(String id)
    {
        ConsultaFragment fragment = new ConsultaFragment();
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

    @Nullable
    @Override
    public View onCreateView(LayoutInflater inflater, @Nullable ViewGroup container, @Nullable Bundle savedInstanceState) {
        return inflater.inflate(R.layout.fragment_consulta, container, false);
    }

    @Override
    public void onViewCreated(View view, @Nullable Bundle savedInstanceState) {
        super.onViewCreated(view, savedInstanceState);

        edtNumero = (EditText)view.findViewById(R.id.edtNumero);
        btConsulta = (Button)view.findViewById(R.id.btConsultar);
        listView = (ListView)view.findViewById(R.id.listView);
    }

    //Cuando se da click sobre un elemento del fragmento
    @Override
    public void onClick(View v)
    {
        switch (v.getId())
        {
            case R.id.btConsultar:
                consultaWebService();
                break;

            default:
                break;
        }
    }

    private void consultaWebService()
    {

    }

    @Override
    public void onResponse(JSONArray response)
    {

    }

    @Override
    public void onErrorResponse(VolleyError error)
    {

    }
}
