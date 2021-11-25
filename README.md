# ClimaTempoSimples

No <b>Web.Config</b>, alterar a **ConnectionString** para a conexão de banco que será utilizada

<pre>
  connectionString="Data Source=SuaMaquina; Initial Catalog=ClimaTempoSimples;User ID=SeuUser;Password=SuaSenha;" 
</pre>

Após atualizar a connection string, executar o seguinte comando no console do gerenciador de pacotes.

<pre>
    Update-Database
</pre>
