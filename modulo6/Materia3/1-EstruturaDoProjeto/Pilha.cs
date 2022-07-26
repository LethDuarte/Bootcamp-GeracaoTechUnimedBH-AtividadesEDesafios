using System;

namespace EstruturaDoPrograma 
{
    public class Pilha // conceito de armazenamento de dados; o útimo item a entrar é o primeiro item a sair
    {
        Posicao primeiro; //propriedade da classe

        //os metodos são membros da classe
        public void Empilha (object item) //metodo empilhar, insere um item na pilha
        {
            primeiro = new Posicao(primeiro, item);
        }

        public object Desempilha() //retira itens da pilha 
        {
            if (primeiro == null)
            {
                throw new InvalidOperationException("A pilha está vazia!"); //interrompe a execução do programa e dispara um erro
            }

            object resultado = primeiro.item;
            primeiro = primeiro.proximo;
            return resultado;
        }

        class Posicao //declaração de classe; subclasse da classe Pilha
        {
            public Posicao proximo; //referencia a outro objeto posição

            public object item; //recebo esse item

            public Posicao (Posicao proximo, object item)
            {
                this.proximo = proximo;
                this.item = item;
            }
        }

    }

}