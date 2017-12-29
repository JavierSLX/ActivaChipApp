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
 * Created by JavierSL on 26/12/2017.
 */

public class ActivadoAdapter extends BaseAdapter
{
    private Context context;
    private JSONArray array;

    public ActivadoAdapter(Context context, JSONArray array)
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
        JSONObject jsonObject;

        try
        {
            jsonObject = array.getJSONObject(position);
        }
        catch (JSONException e)
        {
            jsonObject = null;
        }

        return jsonObject;
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
        View view = convertView;
        if (convertView == null)
            view = inflater.inflate(R.layout.item_basico, null);

        TextView txtNumero = (TextView)view.findViewById(R.id.txtNumero);
        TextView txtMonto = (TextView)view.findViewById(R.id.txtMonto);
        TextView txtCompania = (TextView)view.findViewById(R.id.txtCompania);
        TextView txtFecha = (TextView)view.findViewById(R.id.txtFecha);

        String numero, monto, compania, fecha;
        try
        {
            numero = getItem(position).getString("0");
            monto = getItem(position).getString("1");
            compania = getItem(position).getString("2");
            fecha = getItem(position).getString("3");
        }
        catch (JSONException e)
        {
            numero = null;
            monto = null;
            compania = null;
            fecha = null;
        }

        if (numero != null)
        {
            txtNumero.setText(numero);
            txtMonto.setText(monto);
            txtCompania.setText(compania);
            txtFecha.setText(fecha);
        }

        return view;
    }
}
