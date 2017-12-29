package com.example.javiersl.activachip;

import android.app.ProgressDialog;
import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import com.android.volley.Request;
import com.android.volley.RequestQueue;
import com.android.volley.Response;
import com.android.volley.VolleyError;
import com.android.volley.toolbox.JsonArrayRequest;
import com.android.volley.toolbox.Volley;
import com.example.javiersl.activachip.Resources.Basic;

import org.json.JSONArray;
import org.json.JSONException;

public class Login extends AppCompatActivity implements Basic, View.OnClickListener,
        Response.Listener<JSONArray>, Response.ErrorListener
{
    private EditText edtUsuario, edtPass;
    private Button btAceptar;
    private ProgressDialog progressDialog;

    @Override
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_login);

        edtUsuario = (EditText)findViewById(R.id.edtUser);
        edtPass = (EditText)findViewById(R.id.edtPass);
        btAceptar = (Button)findViewById(R.id.btAceptar);

        btAceptar.setOnClickListener(this);
    }

    //Cuando se presiona un elemento de la aplicación
    @Override
    public void onClick(View v)
    {
        switch (v.getId())
        {
            case R.id.btAceptar:

                //Coloca el dialogo de carga
                progressDialog = new ProgressDialog(this);
                progressDialog.setTitle("Descargando");
                progressDialog.setMessage("Un momento...");
                progressDialog.setProgressStyle(ProgressDialog.STYLE_SPINNER);
                progressDialog.show();

                //Inicia la peticion
                RequestQueue queue = Volley.newRequestQueue(this);
                String cadena = "?host=" + HOST + "&db=" + DB + "&userServer=" +
                        USER + "&passServer=" + PASS + "&user=" +
                        edtUsuario.getText().toString() + "&pass=" +
                        edtPass.getText().toString();
                String url = SERVER + RUTA + "datosLoginCliente.php" + cadena;

                //Hace la petición JSONArray
                JsonArrayRequest jsonArrayRequest = new JsonArrayRequest(Request.Method.GET,
                        url, null, this, this);

                //Pone en cola y ejecuta la petición
                queue.add(jsonArrayRequest);
                break;
            default:
                break;
        }
    }

    //La respuesta de la petición al WebService
    @Override
    public void onResponse(JSONArray response)
    {
        //Oculta el mensaje de progreso
        progressDialog.hide();

        try
        {
            String cliente_id = response.getJSONObject(0).get("cliente_id").toString();

            Bundle bundle = new Bundle();
            bundle.putString("CLIENTEID", cliente_id);
            Intent intent = new Intent(this, Recargas.class);
            intent.putExtras(bundle);
            startActivity(intent);
        }
        catch (JSONException e)
        {
            Toast.makeText(this, "Usuario y/o contraseña incorrecta", Toast.LENGTH_LONG).show();
        }
    }

    //Cuando ocurre un error en el WebService
    @Override
    public void onErrorResponse(VolleyError error)
    {
        //Oculta el mensaje de progreso
        progressDialog.hide();
        Toast.makeText(this, "Error al conectarse al WebService", Toast.LENGTH_SHORT).show();
    }
}
