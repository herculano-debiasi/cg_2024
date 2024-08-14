package desenho2d;

public class Pessoa {
	private String nome;
	private int idade;

	public Pessoa(String nome, int idade) {
		super();
		this.nome = nome;
		this.idade = idade;
	}

	@Override
	public String toString() {
		return "Pessoa [nome=" + nome + ", idade=" + idade + "]";
	}

	public String getNome() { return nome; }
	public int getIdade() { return idade; }
}