import No from "./No.js";
import BuscaBProfundidade from "./BuscaBProfundidade.js";
import BuscaBLargura from "./BuscaBLargura.js";


class ArvoreBinaria{
    
    raiz = null;

    constructor(valor){

        this.raiz = new No (valor);
    }

    buscarPPreOrdem(){
        console.log("Busca em pré-ordem:");
        BuscaBProfundidade.preOrdem(this.raiz);
    }

    buscarPPosOrdem(){
        console.log("Busca em pós-ordem:");
        BuscaBProfundidade.preOrdem(this.raiz);
    }

    buscarPInOrdem(){
        console.log("Busca em in-ordem:");
        BuscaBProfundidade.preOrdem(this.raiz);
    }

    buscaL(){
        console.log("Busca em largura:")
        BuscaBProfundidade.posOrdem(this.raiz);
    }
}

export default ArvoreBinaria;