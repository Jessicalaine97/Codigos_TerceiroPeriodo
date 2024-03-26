import Rastreador from "./Rastreador.js";
import FilaAbertos from "./FilaAbertos.js";

export default class Grafo{
    inicio = null;
    meta = null;

    constructor(inicio,meta){
        this.inicio = inicio;
        this.meta = meta;
    }

    buscaMelhorEscolha(){
       let fila = []; //Array de Rastreadores que vão indicar o caminho
       let ordenados = []; // Array de vertices adjacentes ordenados pela heuristca getOrdenados();
       let atual; //Rastreador atual
       
       fila.push(new Rastreador(this.inicio,null));

       while (fila.length > 0) {
        
            atual = fila.shift();
            if (atual.vertice == this.meta){
                return atual;
            }else{
                ordenados = atual.vertice.getOrdenados();
                ordenados.forEach(adjacente => {
                    fila.push(new Rastreador(adjacente,atual));
                });
            }
       }       
        return null;
    }

    buscaAestrela(){
        let abertos = new FilaAbertos();
        let atual;
        let fechados=new Map();

        abertos.adicionar (new Rastreador(this.inicio, null, 0));
        atual=abertos.retiraPrimeiro();

        while(atual!=null){
            if(atual.vertice==this.meta){
                return atual;
            }else{
                fechados.set(atual.vertice.valor, atual);
                atual.vertice.adjacentes.forEach(vertice =>{
                    if(!fechados.has(vertice.valor)){
                        if(!abertos.contem(vertice)){
                            abertos.adicionar(new Rastreador(vertice, atual, vertice.heuristica))
                        }
                    }
                });
            }
            atual=abertos.retiraPrimeiro();
        }
    }
}