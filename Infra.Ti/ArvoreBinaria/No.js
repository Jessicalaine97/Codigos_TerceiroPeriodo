class No {

    valor = "";
    noEsquerdo = null;
    noDireito = null;

    constructor(valor){
        this.valor = valor;
    }

    adicionaFilhoEsquerda(no){
        if(no instanceof No){
            this.noEsquerdo = no;
        }else{
            throw new exception('Era esperado um nó como filho');
        }
    }

    adicionaFilhoDireita(no){
        if(no instanceof No){
            this.noDireito = no;
        }else{
            throw new exception('Era esperado um nó como filho');
        }
    }
}

export default No;