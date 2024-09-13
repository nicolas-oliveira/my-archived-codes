package br.edu.uemg.progiv.appcadprodutos.Adapters;

import android.content.Context;
import android.view.View;
import android.view.ViewGroup;
import android.widget.BaseAdapter;
import android.widget.TextView;

import org.w3c.dom.Text;

import java.util.List;

import br.edu.uemg.progiv.appcadprodutos.Model.ProdutosModel;
import br.edu.uemg.progiv.appcadprodutos.R;

public class ProdutosAdapter extends BaseAdapter {

    Context context;
    List<ProdutosModel> produtosModelList;

    public ProdutosAdapter(Context context, List<ProdutosModel> produtosModelList) {
        this.context = context;
        this.produtosModelList = produtosModelList;
    }

    @Override
    public int getCount() {
        return produtosModelList.size();
    }

    @Override
    public Object getItem(int position) {
        return produtosModelList.get(position);
    }

    @Override
    public long getItemId(int position) {
        return position;
    }

    @Override
    public View getView(int position, View convertView, ViewGroup parent) {

        View v = View.inflate(this.context, R.layout.item_produto, null);
        TextView txtNome      = (TextView) v.findViewById(R.id.txtNomeProduto);
        TextView txtDescricao = (TextView) v.findViewById(R.id.txtDescricaoProduto);
        TextView txtQte       = (TextView) v.findViewById(R.id.txtQte);

        txtNome.setText(this.produtosModelList.get(position).getNome());
        txtDescricao.setText(this.produtosModelList.get(position).getDescricao());
        txtQte.setText(String.valueOf(this.produtosModelList.get(position).getQuantidade()));

        return v;
    }
}
