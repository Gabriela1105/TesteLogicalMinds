import { Component, Inject } from '@angular/core';
import { FormControl, FormGroup, Validators, FormBuilder } from '@angular/forms';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClient } from '@angular/common/http';
import { Cliente } from '../Models/Cliente';
import { Telefone } from '../Models/Telefone';
import { Endereco } from '../Models/Endereco';
import { Observable } from 'rxjs';



@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public clientes: Cliente[] ;
  public baseUrl: string;
  public http: HttpClient;
  formControl = new FormGroup
  ({
   Id: new FormControl(''),
   Nome: new FormControl(''),
   RG: new FormControl(''),
   CPF: new FormControl(''),
   DataNascimento: new FormControl(''),
   NomeProgenitor1: new FormControl(''),
   NomeProgenitor2: new FormControl(''),
   E_mail: new FormControl(''),
   Profissao: new FormControl(''),
   DataEmissao: new FormControl(''),
   Conta: new FormControl(''),
   Agencia: new FormControl(''),
   Pix: new FormControl('')
  });

  

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string, private formBuilder: FormBuilder) {
    this.baseUrl = baseUrl;
    this.http = http;
    this.load();
    this.baseUrl = baseUrl;
  }

  ngOnInit() {
    this.formControl = this.formBuilder.group({
      Nome: ['', Validators.required], //new FormControl(''),
      RG: ['', Validators.required], //new FormControl(''),
      CPF: ['', Validators.required], //new FormControl(''),
      DataNascimento: ['', Validators.required], //new FormControl(''),
      NomeProgenitor1: ['', Validators.required], //new FormControl(''),
      NomeProgenitor2: ['', Validators.required], //new FormControl(''),
      E_mail: ['', Validators.required], //new FormControl(''),
      Profissao: ['', Validators.required], //new FormControl(''),
      DataEmissao: ['', Validators.required], //new FormControl(''),
      Conta: ['', Validators.required], //new FormControl(''),
      Agencia: ['', Validators.required], //new FormControl(''),
      Pix: ['', Validators.required], //new FormControl('')
    });
  }

  async load() {
    await this.http.get<Cliente[]>(this.baseUrl + 'api/cliente/all').subscribe(r => this.clientes = r);
  }

  async save() {
    let clientes = new Cliente();
    clientes.Id = 0;
    clientes.Nome = this.formControl.controls['Nome'].value;
    clientes.RG = this.formControl.controls['RG'].value;
    clientes.CPF = this.formControl.controls['CPF'].value;
    clientes.DataNascimento = this.formControl.controls['DataNascimento'].value;
    clientes.NomeProgenitor1 = this.formControl.controls['NomeProgenitor1'].value;
    clientes.NomeProgenitor2 = this.formControl.controls['NomeProgenitor2'].value;
    clientes.E_mail = this.formControl.controls['E_mail'].value;
    clientes.Profissao = this.formControl.controls['Profissao'].value;
    clientes.DataEmissao = this.formControl.controls['DataEmissao'].value;
    clientes.Conta = this.formControl.controls['Conta'].value;
    clientes.Agencia = this.formControl.controls['Agencia'].value;
    clientes.Pix = this.formControl.controls['Pix'].value;

    await this.http.post<Cliente>(this.baseUrl + 'api/cliente/save', clientes).subscribe((res) => {
    });
 
  }

}
