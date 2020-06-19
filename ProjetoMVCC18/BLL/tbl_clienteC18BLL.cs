using ProjetoMVCC18.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMVCC18.BLL
{
    class tbl_clienteC18BLL
    {
        private DALMVC DaoBanco = new DALMVC();

        public Boolean consultarBeneficio(string cpf, string nome, string mae)
        {
            string consulta = string.Format($@"select * from tbl_clienteC18 where cpf_cliente = '{cpf}' and nome_cliente = '{nome}' and nome_mae = '{mae}';");
            DataTable dt = DaoBanco.executarConsulta(consulta);
            if (dt.Rows.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }




    }
}
