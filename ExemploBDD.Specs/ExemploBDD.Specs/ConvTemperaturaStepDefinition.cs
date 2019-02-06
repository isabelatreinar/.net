using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using ExemploBDD;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExemploBDD.Specs
{
    [Binding]
    [TestClass]
    public sealed class ConvTemperaturaStepDefinition
    {
        // For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef
        private double _temperaturaFahrenheit;
        private double _temperaturaCelsius;
        private double _temperaturaKelvin;
        
        [Given("que o valor da temperatura é de (.*) graus Fahrenheit")]
        public void CarregarTemperaturaFahrenheit(double temperatura)
        {
            this._temperaturaFahrenheit = temperatura;
        }

        [When("eu solicitar a conversão dessa temperatura")]
        public void ProcessarConversaoTemperatura()
        {
            this._temperaturaCelsius = ConversorTemperatura.FahrenheitParaCelsius(this._temperaturaFahrenheit);
            this._temperaturaKelvin = ConversorTemperatura.FahrenheitParaKelvin(this._temperaturaKelvin);
            // ScenarioContext.Current.Pending();
        }

        [Then("o resultado da conversão para Celsius será de (.*) graus")]
        public void VerificarTemperaturaCelsius(double temperatura)
        {
            Assert.AreEqual(temperatura, this._temperaturaCelsius);
        }

        [Then("o resultado da conversão para Kelvin será de (.*) graus")]
        public void VerificarTemperaturaKelvin(double temperatura)
        {
            Assert.AreEqual(temperatura, this._temperaturaKelvin);
        }
    }
}
