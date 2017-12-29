package com.example.javiersl.activachip.Adapters;

import android.support.v4.app.Fragment;
import android.support.v4.app.FragmentManager;
import android.support.v4.app.FragmentPagerAdapter;
import android.support.v4.app.FragmentStatePagerAdapter;

import java.util.ArrayList;
import java.util.List;

/**
 * Created by JavierSL on 23/12/2017.
 */

public class ViewPagerAdapter extends FragmentStatePagerAdapter
{
    private List<Fragment> listaFragment = new ArrayList<>();
    private List<String> listaTitulos = new ArrayList<>();

    public ViewPagerAdapter(FragmentManager fm)
    {
        super(fm);
    }

    public void addFragment(Fragment fragment, String titulo)
    {
        listaFragment.add(fragment);
        listaTitulos.add(titulo);
    }

    @Override
    public Fragment getItem(int position)
    {
        return listaFragment.get(position);
    }

    @Override
    public int getCount()
    {
        return listaFragment.size();
    }

    @Override
    public CharSequence getPageTitle(int position)
    {
        return listaTitulos.get(position);
    }
}
