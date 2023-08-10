using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CursoWindowsFormsBiblioteca.DataBase
{
    public class Fichario
    {
        public string diretorio;
        public string mensagem;
        public bool status;

        public Fichario(string Diretorio)
        {
            status = true;
            try
            {
                if (!(Directory.Exists(Diretorio)))
                {
                    Directory.CreateDirectory(Diretorio);
                }
                diretorio = Diretorio;
                mensagem = "Conexão com o fichario criada com sucesso";
            }
            catch( Exception ex){ 
                status = false;

                mensagem = "Conexão com o fichario não foi criada: " + ex.Message;
            }

            
        }

        public void Incluir(string Id, string jsonUnit)
        {
            status = true;
            try
            {
                if (File.Exists(diretorio + "\\" + Id + ".json"))
                {
                    status = false;
                    mensagem = "Inclusão negada, o id " + Id + " já existe.";
                }
                else
                {
                    File.WriteAllText(diretorio + "\\" + Id + ".json", jsonUnit);
                    status = true;
                    mensagem = "Inclusão efetuada com sucesso";
                }
            }catch(Exception ex)
            {
                status = false;
                mensagem = "Conexão com o fichario não foi criada: " + ex.Message;
            }

        }

        public string Buscar(string Id)
        {
            status = true;
            try
            {
                if (!(File.Exists(diretorio + "\\" + Id + ".json")))
                {
                    status = false;
                    mensagem = "Identificador não existente." + Id;
                }
                else
                {
                    string conteudo = File.ReadAllText(diretorio+"\\"+Id+".json");
                    status = true;
                    mensagem = "inclusão realizada com sucesso, Identificador:" + Id;
                    return conteudo;
                }

            }
            catch( Exception ex)
            {
                status = false;
                mensagem = "Erro ao buscar conteúdo do Identificador: " + ex.Message;
            }
            return "";
        }
           
    }
}
