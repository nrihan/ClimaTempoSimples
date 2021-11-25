# ClimaTempoSimples

No <b>Web.Config</b>, alterar a **ConnectionString** para a conexão de banco que será utilizada

<pre>
  '<connectionStrings>
    <add name="EFConnectionString" connectionString="Data Source=SuaMaquina; Initial Catalog=ClimaTempoSimples;User ID=SeuUser;Password=SuaSenha;" providerName="System.Data.SqlClient"/>
  </connectionStrings>'
</pre>

Após atualizar a connection string, executar o seguinte comando no console do gerenciador de pacotes.

<pre>
    Update-Database
</pre>
