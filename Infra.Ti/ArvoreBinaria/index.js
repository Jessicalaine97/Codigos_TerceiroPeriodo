import No from"./No.js";
import ArvoreBinaria from"./ArvoreBinaria.js";
//no max 2 filhos

let raiz = new ArvoreBinaria;

let noA = arvoreB.raiz;
let noC = new No('C'); 
let noD = new No('D');
let noE = new No('E');
let noF = new No('F');

noA.adicionaFilhoEsquerda(noB);
noA.adicionaFilhoDireita(noC);
noB.adicionaFilhoEsquerda(noF);
noC.adicionaFilhoEsquerda(noD);
noC.adicionaFilhoDireita(noE);

console.log(arvore);

arvoreB.buscarPPreOrdem();