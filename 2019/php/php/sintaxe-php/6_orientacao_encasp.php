<?php
/* Exemlplo de encapsulamento usando classes */
class Funcionario {
    
    private $nome;
    private $salarioBase;
    private $horasExtras;
    private $valorDahora;

    public function setNome($n) {   
        $this->nome = $n;
    }

    public function setSalarioBase($base) {
        $this->salarioBase = $base;
    }

    public function setHorasExtras($extra) {
        $this->horasExtras = $extra;
    }

    public function setValorDaHora($valor) {
        $this->valorDaHora = $valor;
    }

    public function getSalarioEfetivo() {
        return $this->salarioBase + ($this->horasExtras * $this->ValorDaHora);
    }

}