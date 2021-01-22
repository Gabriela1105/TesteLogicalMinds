import { Pix } from '../Enums/Pix';
import { Telefone } from './Telefone';
import { Endereco } from './Endereco';

export class Cliente {
  Id: number;
  Nome: string;
  RG: number;
  CPF: number;
  DataNascimento: Date;
  NomeProgenitor1: string;
  NomeProgenitor2: string;
  E_mail: string;
  Profissao: string;
  DataEmissao: Date;
  Conta: number;
  Agencia: number;
  Pix: Pix;
  Telefone: Telefone[];
  Endereco: Endereco[];
}

