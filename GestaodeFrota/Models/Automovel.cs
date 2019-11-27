﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaodeFrota.Models
{
    public class Automovel
    {
        public int Id { get; set; }
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public DateTime Ano { get; set; }
        public int Quilometragem { get; set; }
        public Boolean Alugado { get; set; }
        public Boolean Disponivel { get; set; }
        public Apolice Apolice { get; set; }
        public ICollection<Abastecimento> Abastecimento { get; set; } = new List<Abastecimento>();
        public ICollection<Viagem> Viagem { get; set; } = new List<Viagem>();
        public ICollection<Manutencao> Manutencao { get; set; } = new List<Manutencao>();
        public ICollection<Multa> Multa { get; set; } = new List<Multa>();
        public ICollection<Motorista> Motorista { get; set; } = new List<Motorista>();

        public Automovel()
        {
        }

        public Automovel(int id, string placa, string marca, string modelo, DateTime ano, int quilometragem, bool alugado, bool disponivel, Apolice apolice)
        {
            this.Id = id;
            this.Placa = placa;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Ano = ano;
            this.Quilometragem = quilometragem;
            this.Alugado = alugado;
            this.Disponivel = disponivel;
            this.Apolice = apolice;
        }
        //Metodo para adicionar e remover um abastecimento
        public void AddAbastecimento(Abastecimento abt)
        {
            Abastecimento.Add(abt);
        }

        public void RemoveAbastecimento(Abastecimento abt)
        {
            Abastecimento.Remove(abt);
        }
        //Metodo para adicionar e remover uma Viagem
        public void AddViagem(Viagem vg)
        {
            Viagem.Add(vg);
        }

        public void RemoveViagem(Viagem vg)
        {
            Viagem.Remove(vg);
        }
        //Metodo para adicionar e remover uma Manutencao
        public void AddManutencao(Manutencao mn)
        {
            Manutencao.Add(mn);
        }

        public void RemoveManutencao(Manutencao mn)
        {
            Manutencao.Remove(mn);
        }
        //Metodo para adicionar e remover uma Multa
        public void AddMulta(Multa mt)
        {
            Multa.Add(mt);
        }

        public void RemoveMulta(Multa mt)
        {
            Multa.Remove(mt);
        }
        //Metodo para adicionar e remover um Motorista
        public void AddMotorista(Motorista mtt)
        {
            Motorista.Add(mtt);
        }

        public void RemoveMotorista(Motorista mtt)
        {
            Motorista.Remove(mtt);
        }
        //Metodo para calcular o valor dos abastecimento informando data inicial e data final
        public double TotalAbastecimento(DateTime inicial, DateTime final)
        {
            return Abastecimento.Where(abt => abt.DataAbaste >= inicial && abt.DataAbaste <= final).Sum(abt => abt.ValorAbaste);
        }
        //Metodo para calcular valores das Manutencoes informando data inicial e data final
        public double TotalManutecao(DateTime inicial, DateTime final)
        {
            return Manutencao.Where(mtt => mtt.DataManutencao >= inicial && mtt.DataManutencao <= final).Sum(mtt => mtt.Valor);
        }
        //Metodo para calcular o valor das Multas informando data inicial e data final
        public double TotalMulta(DateTime inicial, DateTime final)
        {
            return Multa.Where(mt => mt.DataMulta >= inicial && mt.DataMulta <= final).Sum(mt => mt.Valor);
        }


    }
}