import { Component } from '@angular/core';
import { SeguroService } from './seguro.service';

@Component({
  selector: 'app-seguro',
  templateUrl: './seguro.component.html',
})
export class SeguroComponent {
  novoSeguro: any = {
    valorVeiculo: null,
    marcaModeloVeiculo: '',
    nomeSegurado: '',
    cpf: '',
    idade: null,
  };

  seguros: any[] = [];
  relatorio: any;

  constructor(private seguroService: SeguroService) {

  }


  createSeguro() {
    this.seguroService.createSeguro(this.novoSeguro).subscribe(() => {
      // Limpa os campos após criar o seguro
      this.novoSeguro = {
        valorVeiculo: null,
        marcaModeloVeiculo: '',
        nomeSegurado: '',
        cpf: '',
        idade: null,
      };
    });
  }

  showSeguro(id: number) {
    // Implemente a função para visualizar os detalhes do seguro
    // Talvez usando um modal ou outra tela
  }

  generateReport() {
    this.seguroService.generateReport().subscribe((data) => {
      this.relatorio = data;
    });
  }
}
