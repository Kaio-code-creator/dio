// Definição da classe Heroi
class Heroi {
    constructor(nome, idade, tipo) {
        this.nome = nome;
        this.idade = idade;
        this.tipo = tipo;
    }

    atacar() {
        let ataque;
        switch (this.tipo) {
            case 'mago':
                ataque = 'usou magia';
                break;
            case 'guerreiro':
                ataque = 'usou espada';
                break;
            case 'monge':
                ataque = 'usou artes marciais';
                break;
            case 'ninja':
                ataque = 'usou shuriken';
                break;
            default:
                ataque = 'usou um ataque indefinido';
        }

        console.log(`O ${this.tipo} atacou usando ${ataque}`);
    }
}

// Exemplo de uso da classe Heroi
const heroiExemplo = new Heroi('Gandalf', 1500, 'mago');
heroiExemplo.atacar();  // Saída esperada: "O mago atacou usando magia"