using SbRf.Gestao.Core.Entities;
using SbRf.Gestao.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp.ViewModels
{
    public class ProdutoViewModel
    {
        private readonly IRepositoryUnidadeDeMedida _repositoryUnidadeDeMedida;
        public ObservableCollection<string> Unidades { get; }

        private string _unidadeSelecionada;
        public string UnidadeSelecionada
        {
            get => _unidadeSelecionada;
            set
            {
                if (_unidadeSelecionada != value)
                {
                    _unidadeSelecionada = value;
                    OnPropertyChanged(nameof(UnidadeSelecionada));
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        public ProdutoViewModel(IRepositoryUnidadeDeMedida repositoryUnidadeDeMedida)
        {
            _repositoryUnidadeDeMedida = repositoryUnidadeDeMedida;
            Unidades = new ObservableCollection<string>(LoadUnidadeDeMedidaAsync().Result);
            UnidadeSelecionada = "UN";
        }

        private async Task<IEnumerable<string>> LoadUnidadeDeMedidaAsync()
        {
            var unidadesDeMedida = await _repositoryUnidadeDeMedida.GetAllAsync();
            return unidadesDeMedida.Select(u => u.Simbolo.Trim());

        }
    }
}
