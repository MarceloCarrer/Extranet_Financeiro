import { PoloRelatorio } from "./PoloRelatorio";

export interface PoloTurma {
  id: number;
  turmaId: number;
  turma: string;
  mes: number;
  ano: number;
  valorPago: number;
  porcSenacrs: number;
  porcPolo: number;
  devolucao: number;
  porcDevSenacrs: number;
  porcDevPolo: number;
  percenSenacrs: number;
  percenPolo: number;
  poloRelatorioId: number;
  poloRelatorio: PoloRelatorio[];
}
