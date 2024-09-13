const btnSubmit = document.querySelector('.btn-login');
const form = document.querySelector('form');

btnSubmit.addEventListener("click", (event) => {
  event.preventDefault();/* Previne de fazer o submit do botão */

  const fields = [ ... document.querySelectorAll('.input-block input')];

  fields.forEach(field => {
    if(field.value == "") form.classList.add("validate-error")
  });

  const formError = document.querySelector(".validate-error");
  if (formError) {
    formError.addEventListener("animationend", (event) => {
      if (event.animationName == 'nono') {
        formError.classList.remove("validate-error");
      }
    });
  } else {
    form.classList.add("form-hide");/* Adiciona a classe ao clicar */
  }
});

form.addEventListener('animationstart', (event) => {
  if (event.animationName == 'down') { /* Verifica se a animação que foi iniciada é a down */
    document.querySelector('body').style.overflow = 'hidden'; /* Previne de aparecer o scroll da pagina durante o evento */
  }
});

form.addEventListener('animationend', (event) => {
  if (event.animationName == 'down') { 
    form.style.display = 'none'; /* Retira a caixa ao finalizar a animação */
    document.querySelector('body').style.overflow = 'none';
  }
});

/* Background Squares */

const ulSquares = document.querySelector("ul.squares");
/* Função responsável por criar quadrados diferentes */
for (let i = 0; i < 11; i++) {

  const li = document.createElement("li");
  /* Função interna de  */
  const random = (min, max) => Math.random() * (max - min) + min;
  
  const size = Math.floor(random(10, 120));
  const delay = random(5, 0.1);
  const duration = random(24, 12);
  /* Definição da propriedade css */
  li.style.width = `${size}px`;
  li.style.height = `${size}px`;

  // const position = Math.random() * (99 - 1) + 1;
  const position = random(1, 99);

  /* Esconde todos os quadrados até o maior */
  li.style.bottom = `-${size}px`;

  li.style.left = `${position}%`;
  li.style.animationDelay = `${delay}s`;
  li.style.animationDuration = `${duration}s`;
  li.style.animationTimingFunction = `cubic-bezier(${Math.random()})`
  ulSquares.appendChild(li);

}