import { PoloRelatorio } from "./PoloRelatorio";

export interface Relatorio {

  id: number;
  mes: number;
  ano: number;
  valorPago: number;
  porcSenacrs: number;
  porcPolo: number;
  devolucao: number;
  porcDevSenacrs: number;
  porcDevPolo: number;
  dataRegistro: Date;
  dataAtualizacao?: Date;
  poloRelatorio: PoloRelatorio[];
}
