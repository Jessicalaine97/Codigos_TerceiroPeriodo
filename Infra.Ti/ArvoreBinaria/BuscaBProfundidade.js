class BuscaBProfundidade{

    static preOrdem(no){ //VLR
        
        if(!no){ //no ! ""
            return;
        }
        console.log(no.valor);

        BuscaBProfundidade.preOrdem(no.filhoEsquerda);

        BuscaBProfundidade.preOrdem(no.filhoDireita);
    }

    static posOrdem(no){ //LRV
        
        if(!no){ //no ! ""
            return;
        }

        BuscaBProfundidade.preOrdem(no.filhoEsquerda);

        BuscaBProfundidade.preOrdem(no.filhoDireita);

        console.log(no.valor);
    }

    static inOrdem(no){ //LVR
        
        if(!no){ //no ! ""
            return;
        }

        BuscaBProfundidade.preOrdem(no.filhoEsquerda);

        console.log(no.valor);

        BuscaBProfundidade.preOrdem(no.filhoDireita);
    }
}

export default BuscaBProfundidade;
