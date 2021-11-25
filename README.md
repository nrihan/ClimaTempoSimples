# ClimaTempoSimples

No <b>Web.Config</b>, alterar a **ConnectionString** para a conex�o de banco que ser� utilizada

<pre>
  <connectionStrings>
    <add name="EFConnectionString" connectionString="Data Source=SuaMaquina; Initial Catalog=ClimaTempoSimples;User ID=SeuUser;Password=SuaSenha;" providerName="System.Data.SqlClient"/>
  </connectionStrings>
</pre>

Ap�s atualizar a connection string, executar o seguinte comando no console do gerenciador de pacotes.

<pre>
    Update-Database
</pre>