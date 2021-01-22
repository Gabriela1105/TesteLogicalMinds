import { Component, Inject } from '@angular/core';
import { FormControl, FormGroup, Validators, FormBuilder } from '@angular/forms';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClient } from '@angular/common/http';
import { Cliente } from '../Models/Cliente';


@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public clientes: Cliente[];
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
    http.get<Cliente[]>(baseUrl + 'api/cliente/all').subscribe(result => {
      this.clientes = result;
    }, error => console.error(error));
    this.baseUrl = baseUrl;
    this.http = http;
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
    })
  }

  async save() {
    let clientes = new Cliente();
    clientes.Id = this.formControl.controls['Id'].value;
    clientes.Nome = this.formControl.controls['Nome'].value;

    await this.http.post<Cliente[]>(this.baseUrl, clientes).subscribe((res) => {
    });
 
  }

}
