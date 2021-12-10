import { PoloTurma } from "./PoloTurma";
import { Relatorio } from "./Relatorio";

export interface PoloRelatorio {
  id: number;
  poloId: number;
  mes: number;
  ano: number;
  dr: string;
  nome : string;
  cnpj? : string;
  valorPago: number;
  porcSenacrs: number;
  porcPolo: number;
  devolucao: number;
  porcDevSenacrs: number;
  porcDevPolo: number;
  relatorioId: number;
  relatorio: Relatorio[];
  poloTurma: PoloTurma[];
}
