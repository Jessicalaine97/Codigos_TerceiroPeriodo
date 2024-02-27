class BuscaBLargura{

    static buscar(raiz){
        let atual = null;
        let lista = new Array();

        if (!raiz){ //se raiz veio vazia
            return; 
        }

        lista.push(raiz); //adiciona no final

        while(lista.length > 0){
            atual = lista.shift(); //tira o primeiro da lista
            console.log(atual.valor); //visita ele

            if(atual.filhoEsquerda){
                lista.push(atual.filhoEsquerda);
            }
    
            if(atual.filhoDireita){
                lista.push(atual.filhoDireita);
            }
        }
    }
}

export default BuscaBLargura;