var btn = document.querySelector(".row label:nth-child(5) button")

var campos = document.querySelectorAll(".row input")
//capturar mais de um elemento ao msm tmp
console.log(campos)

//funcao para aparecer o botao ou nao caso os campos estejam preenchidos
const fnt = (=>{
    if(campos[0].value != '' && campos[1].value != '' &&)
    {
        btn.style.visibility = 'show'
    } else {
        btn.style.visibility = 'hidden'
    }
})

campos.forEach(i -> i.change = fnt)

//btn.style.display = 'none'

//console.log(btn)


