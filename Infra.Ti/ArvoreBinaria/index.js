import No from "./No.js"
import ArvoreBuscaBinaria from"./ArvoreBuscaBinaria.js";
import ArvoreBinaria from"./ArvoreBinaria.js";
import BuscaBLargura from "./BuscaBLargura.js";
//no max 2 filhos

//let arvoreB = new ArvoreBinaria('A');
let arvoreBST = new ArvoreBuscaBinaria(100);//cria raiz
//let raiz = arvoreB.raiz;

// let noA = arvoreB.raiz;
// let noB = new No('B');
// let noC = new No('C'); 
// let noD = new No('D');
// let noE = new No('E');
// let noF = new No('F');

// noA.adicionaFilhoEsquerda(noB);
// noA.adicionaFilhoDireita(noC);
// noB.adicionaFilhoEsquerda(noF);
// noC.adicionaFilhoEsquerda(noD);
// noC.adicionaFilhoDireita(noE);

// arvoreB.buscarPPreOrdem();
// arvoreB.buscarPPosOrdem();
// arvoreB.buscarPInOrdem();

//arvoreB.buscaL();

//console.log(arvoreBST.buscar("E"));

arvoreBST.inserir(50); 
arvoreBST.inserir(200);
arvoreBST.inserir(30);
arvoreBST.inserir(30);
arvoreBST.inserir(70);
arvoreBST.inserir(140);
arvoreBST.inserir(400);
arvoreBST.inserir(42);
arvoreBST.inserir(65);
arvoreBST.inserir(80);
arvoreBST.inserir(105);
arvoreBST.inserir(107);
arvoreBST.inserir(350);

BuscaBLargura.buscar(arvoreBST.raiz);
