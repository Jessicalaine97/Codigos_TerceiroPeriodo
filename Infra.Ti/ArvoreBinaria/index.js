import No from"./No.js";
import ArvoreBinaria from"./ArvoreBinaria.js";
//no max 2 filhos

let arvoreB = new ArvoreBinaria('A');
let raiz = arvoreB.raiz;

let noA = arvoreB.raiz;
let noB = new No('B');
let noC = new No('C'); 
let noD = new No('D');
let noE = new No('E');
let noF = new No('F');

noA.adicionaFilhoEsquerda(noB);
noA.adicionaFilhoDireita(noC);
noB.adicionaFilhoDireita(noF);
noC.adicionaFilhoDireita(noD);
noC.adicionaFilhoDireita(noE);

arvoreB.buscarPPreOrdem();
arvoreB.buscarPPosOrdem();
arvoreB.buscarPInOrdem();