package com.example.javiersl.activachip;

import android.net.Uri;
import android.support.design.widget.TabLayout;
import android.support.v4.app.FragmentTransaction;
import android.support.v4.view.ViewPager;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.support.v7.widget.Toolbar;

import com.example.javiersl.activachip.Adapters.ViewPagerAdapter;
import com.example.javiersl.activachip.Fragments.ActivosFragment;
import com.example.javiersl.activachip.Fragments.CaducidadFragment;
import com.example.javiersl.activachip.Fragments.ConsultaFragment;
import com.example.javiersl.activachip.Fragments.RecargaFragment;

public class Recargas extends AppCompatActivity
{
    @Override
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_recargas);

        //Obtiene el valor del id
        String cliente_id = getIntent().getExtras().getString("CLIENTEID");

        //Referencia la barra de titulos y el viewpager
        ViewPagerAdapter adapter = new ViewPagerAdapter(getSupportFragmentManager());

        ViewPager viewPager = (ViewPager)findViewById(R.id.viewpager);
        viewPager.setAdapter(adapter);

        TabLayout tabLayout = (TabLayout) findViewById(R.id.tabs);
        tabLayout.setupWithViewPager(viewPager);

        //Notifica que cambia el adapter
        adapter.addFragment(RecargaFragment.newInstance(cliente_id), "Recarga");
        adapter.addFragment(ActivosFragment.newInstance(cliente_id), "Activados");
        adapter.addFragment(CaducidadFragment.newInstance(cliente_id), "Caducidad");
        adapter.addFragment(ConsultaFragment.newInstance(cliente_id), "Consulta");
        adapter.notifyDataSetChanged();
    }
}
