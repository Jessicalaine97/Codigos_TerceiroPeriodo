class No {

    valor = "";
    filhoEsquerda = null;
    filhoDireita = null;

    constructor(valor){
        this.valor = valor;
    }

    adicionaFilhoEsquerda(no){
        if(no instanceof No){
            this.filhoEsquerda = no;
        }else{
            throw new exception('Era esperado um nó como filho');
        }
    }

    adicionaFilhoDireita(no){
        if(no instanceof No){
            this.filhoDireita = no;
        }else{
            throw new exception('Era esperado um nó como filho');
        }
    }
}

export default No;