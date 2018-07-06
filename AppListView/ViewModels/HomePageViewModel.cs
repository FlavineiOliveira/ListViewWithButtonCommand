using AppListView.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppListView.ViewModels
{
	public class HomePageViewModel : INotifyPropertyChanged
	{
		private List<Aluno> _aluno = new List<Aluno>();
		public List<Aluno> Aluno { get; set; }

		private ICommand _selecionarItem;

		public event PropertyChangedEventHandler PropertyChanged;

		private string _nomeSelecionado { get; set; }
		private string _escolaSelecionado { get; set; }

		public string NomeSelecionado
		{
			get
			{
				return _nomeSelecionado;
			}
			set
			{
				_nomeSelecionado = value;
				RaisePropertyChanged("NomeSelecionado");
			}
		}

		private void RaisePropertyChanged(string v)
		{
			if (PropertyChanged != null)
				PropertyChanged(this, new PropertyChangedEventArgs(v));
		}

		public string EscolaSelecionado
		{
			get
			{
				return _escolaSelecionado;
			}
			set
			{
				_escolaSelecionado = value;
				RaisePropertyChanged("EscolaSelecionado");
			}
		}

		public HomePageViewModel()
		{
			PreencherLista();

			Aluno = _aluno;
		}

		void PreencherLista()
		{
			_aluno.Add(new Aluno { Nome = "Flavinei", Escola = "E. E. Dr. Christiano Altenfelder Silva" });
			_aluno.Add(new Aluno { Nome = "Diego", Escola = "E. E. José Vieira" });
		}

		public ICommand SelecionarItem
		{
			get
			{
				return _selecionarItem ?? (_selecionarItem = new Command<Aluno>(objeto =>
				{
					Aluno teste = objeto;

					NomeSelecionado = teste.Nome;
					EscolaSelecionado = teste.Escola;
				}));
			}
		}

	}
}
