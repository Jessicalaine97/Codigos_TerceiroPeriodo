import Grafo from "./Grafo.js";
import Aresta from "./Aresta.js";

//vertice
let v = new Vertice("v");
let u = new Vertice("u");
let w = new Vertice("w");
let x = new Vertice("x");
let y = new Vertice("y");

v.adicionaAresta(u,0);
v.adicionaAresta(w,0);
v.adicionaAresta(x,0);
v.adicionaAresta(u,0);
v.adicionaAresta(x,0);
v.adicionaAresta(x,0);
v.adicionaAresta(x,0);
v.adicionaAresta(y,0);

//grafo
let a = new Vertice("a"); 
let b = new Vertice("b");
let c = new Vertice("c");
let d = new Vertice("d");
let e = new Vertice("e");
let f = new Vertice("f");
let g = new Vertice("g");
let s = new Vertice("s");
let t = new Vertice("t");

//s -> inicio e t -> fim
let grafo = new Grafo(s,t);

s.adicionaAresta(a,3.1);
s.adicionaAresta(b,3.1);
s.adicionaAresta(c,3.5);
s.adicionaAresta(t,4.8);

console.log(s.getOrdenados);



