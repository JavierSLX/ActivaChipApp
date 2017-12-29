package com.example.javiersl.activachip.Adapters;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.BaseAdapter;
import android.widget.TextView;

import com.example.javiersl.activachip.R;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

/**
 * Created by JavierSL on 28/12/2017.
 */

public class CaducidadAdapter extends BaseAdapter
{
    private Context context;
    private JSONArray array;

    public CaducidadAdapter(Context context, JSONArray array)
    {
        this.context = context;
        this.array = array;
    }

    @Override
    public int getCount()
    {
        return array.length();
    }

    @Override
    public JSONObject getItem(int position)
    {
        JSONObject json;

        try
        {
            json = array.getJSONObject(position);
        }
        catch (JSONException e)
        {
            json = null;
        }

        return json;
    }

    @Override
    public long getItemId(int position)
    {
        return position;
    }

    @Override
    public View getView(int position, View convertView, ViewGroup parent)
    {
        LayoutInflater inflater = LayoutInflater.from(parent.getContext());
        View item = convertView;
        if (convertView == null)
            item = inflater.inflate(R.layout.item_basico, null);

        TextView txtNumero = (TextView)item.findViewById(R.id.txtNumero);
        TextView txtDia = (TextView)item.findViewById(R.id.txtMonto);
        TextView txtCompania = (TextView)item.findViewById(R.id.txtCompania);
        TextView txtFecha = (TextView)item.findViewById(R.id.txtFecha);

        String numero;
        String dia;
        String compania;
        String fecha;

        try
        {
            numero = getItem(position).getString("0");
            dia = getItem(position).getString("1");
            compania = getItem(position).getString("2");
            fecha = getItem(position).getString("3");
        }
        catch (JSONException e)
        {
            numero = null;
            dia = null;
            compania = null;
            fecha = null;
        }

        txtNumero.setText(numero);
        txtDia.setText(dia);
        txtCompania.setText(compania);
        txtFecha.setText(fecha);

        return item;
    }
}
