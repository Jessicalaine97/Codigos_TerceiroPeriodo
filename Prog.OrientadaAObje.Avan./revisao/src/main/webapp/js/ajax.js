var campos = document.querySelectAll(".ajax input");
var btns = document.querySelectAll(".ajax button");

console.log(campos);
console.log(btns);

const callAjax =(e)=>{

    fetch(`http://localhost:8080/segundoAjax?cpValor1={campos[0].value}&cpValor2={campos[1].value}&btn={e.target.value}`,
    {
        method: "GET",
        body:{
        
        }
    }).then(r =>{

    })
}