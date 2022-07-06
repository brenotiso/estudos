## DRY
Don't repeat yourself

Um princípio que visa a redução de repetições em um software, de forma que componentes possuam uma representação única, de autoridade e livre de ambiguidades em todo o sistema.

Como vantagens estão a facilidade na manutenção, testes e coesão do sistema.

O contrário do DRY é conhecido como WET (write  every time, we  enjoy  typing, waste  everyone's time).
  
https://thevaluable.dev/dry-principle-cost-benefit-example/  

“DRY Everything: the  Recipe for Disasters”  
“You  shouldn’t  apply  the DRY principle  if  your business logic  doesn’t  have  any  duplication  yet.”

[https://blog.pragmaticengineer.com/readable-code/](https://blog.pragmaticengineer.com/readable-code/)  
  
Exemplo: No .NET, invés de toda controller fazer a validação ModelState.IsValid, pode ser criado um filtro global para fazer as validações e então emitir um erro antes mesmo de chegar na controller.  

## YAGNI
You  Ain't  Gonna  Need It

Não adicionar funcionalidades ao código fonte de um programa até que estas sejam realmente necessárias.

Famoso fazer o feijão com arroz e, se necessário, evoluir.

“implementar coisas que se realmente precisa, nunca o que se prevê que um dia irá ser preciso.”  

![enter image description here](https://miro.medium.com/max/1200/0*UlaHAzdDrnLIOOND.png)

## Composition Over Inheritance

https://betterprogramming.pub/prefer-composition-over-inheritance-1602d5149ea1
https://www.geeksforgeeks.org/favoring-composition-over-inheritance-in-java-with-examples/

Herança deve ser usada somente se a subclasse 'é' uma super classe. Não usar herança para reutilizar código. Se não tiver uma relação de 'é', use composição (relação de 'tem').

## The Hollywood Principle
"Don't call us, we'll call you"

http://matthewtmead.com/blog/hollywood-principle-dont-call-us-well-call-you-4/

Inversion of Control (IoC) e Observer são bons exemplos. 

## Encapsulate what varies & Program against abstractions

https://bootcamp.uxdesign.cc/software-design-principles-every-developers-should-know-23d24735518e
https://betterprogramming.pub/avoiding-premature-software-abstractions-8ba2e990930a

