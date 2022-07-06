# SOLID

S — Single Responsiblity Principle (Princípio da responsabilidade única) 
O — Open-Closed Principle (Princípio Aberto-Fechado) 
L — Liskov Substitution Principle (Princípio da substituição de Liskov) 
I — Interface Segregation Principle (Princípio da Segregação da Interface) 
D — Dependency Inversion Principle (Princípio da inversão da dependência) 


## Single Responsiblity Principle 

Classes devem possuir um, e apenas um, motivo para mudar. Ou seja, classes devem possuir um objetivo central e responsabilidade única dentro da solução.  

Os problemas derivados são: 
- Dificuldade nos testes, mocks e afins; 

- Dificuldade em reutilizar o código; 

- Maior nível de dependência; 

- Complexidade nas alterações. 

 
Exemplo ruim: 

       TimelineRepositoy{ 
          ObterTimeline() 
          ObterStatusRecentes() 
          ObterAceiteClientes() 
        } 

 

Exemplo bom: 

    ClienteRepository { 
      ObterPorFiltro(filtro) 
    } 
    
    EventoRepository { 
      ObterPorFiltro(filtro) 
    } 

## Open-Closed Principle 

Objetos ou entidades devem estar abertos para extensão, mas fechados para modificação.  

> Como adicionamos um novo comportamento sem alterar o código fonte já
> existente?  
> Separe o comportamento extensível por trás de uma interface e inverta as dependências.

Exemplo ruim: 

    class Pessoa 
    { 
       TipoPessoa tipo; 
       Dinheiro Salario; 
    } 
    
    class FolhaDePagamento 
    { 
        Dinheiro Liquido; 
        Dinheiro Desconto; 
        calcular(Pessoa funcionario) 
        { 
            if (funcionario.Tipo == TipoPessoa.Fisica) { 
                Desconto = funcionario.Salario * 0,2; 
            } else { 
                Desconto = funcionario.Salario * 0,05; 
            } 
            Liquido = funcionario.Salario - Desconto; 
        } 
    } 

Exemplo bom: 

    interface Remuneravel 
    { 
        public function remuneracaoLiquida(); 
    } 
    
    class ContratoClt implements Remuneravel 
    { 
        public function remuneracaoLiquida () {} 
    } 
    
    class ContratoPj implements Remuneravel 
    { 
        public function remuneracaoLiquida () {} 
    } 
    
    class FolhaDePagamento 
    { 
        Dinheiro Liquido; 
        Dinheiro Desconto; 
        calcular(Remuneravel funcionario) 
        { 
            Liquido = funcionario.remuneracaoLiquida(); 
            Desconto = funcionario.Salario - Liquido; 
        } 
    } 

## Liskov Substitution Principle 

Uma classe derivada deve ser substituível por sua classe base, de forma a não alterar o funcionamento esperado. 

O mesmo vale para interfaces. Não adianta implementar a interface se o comportamento não é como esperado. 

 

- Sobrescrever/implementar um método que não faz nada; 

- Lançar uma exceção inesperada; 

- Retornar valores de tipos diferentes da classe base (em js, por exemplo). 

 

## Interface Segregation Principle 

 

Uma classe não deve ser forçada a implementar interfaces e métodos que não irão utilizar. Interfaces usadas de forma generalista podem atrapalhar invés de ajudar. É melhor ter interfaces para poucos “clientes” do que uma interface “gorda” para vários. 

Exemplo ruim:

    interface Aves 
    { 
        public function setLocalizacao($longitude, $latitude); 
        public function setAltitude($altitude); 
        public function renderizar(); 
    } 
    
    class Papagaio implements Aves 
    { 
        public function setLocalizacao($longitude, $latitude) { } 
        public function setAltitude($altitude)  { } 
        public function renderizar() {} 
    } 
    
    class Pinguim implements Aves 
    { 
        public function setLocalizacao($longitude, $latitude) {} 
         // Isso viola o príncipio ISP e LSP 
        public function setAltitude($altitude) 
        { 
            //Não faz nada...  Pinguins são aves que não voam! 
        } 
    
       public function renderizar() 
        { 
            //Faz alguma coisa 
        } 
    } 

Exemplo bom:

    interface Aves 
    { 
        public function setLocalizacao($longitude, $latitude); 
        public function renderizar(); 
    } 
      
    interface AvesQueVoam extends Aves 
    { 
        public function setAltitude($altitude); 
    } 
    
    class Papagaio implements AvesQueVoam 
    { 
        public function setLocalizacao($longitude, $latitude) {} 
        public function setAltitude($altitude) {} 
        public function renderizar() {} 
    } 
    
    class Pinguim implements Aves 
    { 
        public function setLocalizacao($longitude, $latitude) {} 
        public function renderizar() {} 
    } 


## Dependency Inversion Principle 
Dependa de abstrações e não de implementações. 

1. Módulos de alto nível não devem depender de módulos de baixo nível. Ambos devem depender da abstração. 
2. Abstrações não devem depender de detalhes. Detalhes devem depender de abstrações. 

Exemplo ruim:

    class UsuarioService 
    { 
        private $dbConnection; 
        public function __construct() 
        {        
            $this->dbConnection = new MySQLConnection();            
        } 
        // Faz alguma coisa 
    } 

Exemplo bom:

    interface DBConnectionInterface 
    { 
        public function connect(); 
    } 
    
    class MySQLConnection implements DBConnectionInterface 
    { 
        public function connect() {} 
    } 
    
    class OracleConnection implements DBConnectionInterface 
    { 
       public function connect() {} 
    } 
    
    class UsuarioService 
    { 
        private $dbConnection; 
        public function __construct(DBConnectionInterface $dbConnection) { 
            $this->dbConnection = $dbConnection; 
        } 
        // Faz alguma coisa 
    } 

