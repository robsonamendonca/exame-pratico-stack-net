import { Component } from '@angular/core';
import { SeguroService } from './seguro/seguro.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent {
  title = 'webcalcseg';

  relatorio: any;
  seguroService!: SeguroService;

  generateReport1() {
    console.log('data: generateReport1...');
    this.seguroService.generateReport().subscribe((data) => {
      console.log(data);
      this.relatorio = data;
    });
  }
}
