﻿using System;

namespace Classes
{
    class Usuario

    {
        string nome;
        string senha;
        string cpf;
        string email;

        //setter
        public void setSenha(string senha){
            this.senha = senha;
        }

        //getter
        public string getSenha(){ //void = quanto tem algum retorno
            return this.senha;

        }
    }
}




