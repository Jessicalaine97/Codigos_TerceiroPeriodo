class BuscaBProfundidade{

    static preOrdem(no){ //VLR
        
        if(!no){ //no ! ""
            return;
        }
        console.log(no.valor);

        BuscaBProfundidade.preOrdem(no.FilhoEsquerda);

        BuscaBProfundidade.preOrdem(no.FilhoDireita);
    }

    static posOrdem(no){ //LRV
        
        if(!no){ //no ! ""
            return;
        }

        BuscaBProfundidade.preOrdem(no.FilhoEsquerda);

        BuscaBProfundidade.preOrdem(no.FilhoDireita);

        console.log(no.valor);
    }

    static inOrdem(no){ //LVR
        
        if(!no){ //no ! ""
            return;
        }

        BuscaBProfundidade.preOrdem(no.FilhoEsquerda);

        console.log(no.valor);

        BuscaBProfundidade.preOrdem(no.FilhoDireita);
    }
}

export default BuscaBProfundidade;
