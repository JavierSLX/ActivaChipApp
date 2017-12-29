package com.example.javiersl.activachip.Fragments;

import android.app.Dialog;
import android.content.DialogInterface;
import android.os.Bundle;
import android.support.annotation.NonNull;
import android.support.annotation.Nullable;
import android.support.v4.app.DialogFragment;
import android.support.v7.app.AlertDialog;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.TextView;

import com.example.javiersl.activachip.R;

/**
 * Created by JavierSL on 23/12/2017.
 */

public class AlertaFragment extends DialogFragment
{
    public static AlertaFragment newInstance(boolean correcto, String texto)
    {
        AlertaFragment alertaFragment = new AlertaFragment();
        Bundle bundle = new Bundle();
        bundle.putBoolean("CORRECTO", correcto);
        bundle.putString("MENSAJE", texto);
        alertaFragment.setArguments(bundle);
        return alertaFragment;
    }

    @NonNull
    @Override
    public Dialog onCreateDialog(Bundle savedInstanceState)
    {
        //Infla la vista y el builder necesario
        AlertDialog.Builder builder = new AlertDialog.Builder(getActivity());
        LayoutInflater inflater = getActivity().getLayoutInflater();
        View vista = inflater.inflate(R.layout.alert_dialog, null);

        ImageView imgAlerta = (ImageView) vista.findViewById(R.id.imgAlerta);
        TextView txtMensaje = (TextView) vista.findViewById(R.id.txtMensaje);

        //Argumentos que se rescatan del fragmento
        Bundle bundle = getArguments();
        int icono;
        String mensaje = bundle.getString("MENSAJE");
        if (bundle.getBoolean("CORRECTO"))
            icono = R.drawable.ic_correcto;
        else
            icono = R.drawable.ic_incorrecto;

        imgAlerta.setImageResource(icono);
        txtMensaje.setText(mensaje);

        //Arma el dialogo y sus contenidos
        builder.setView(vista).setTitle("Mensaje").setPositiveButton("Aceptar", new DialogInterface.OnClickListener()
            {
                @Override
                public void onClick(DialogInterface dialog, int which)
                {
                }
            });

        return builder.create();
    }
}
