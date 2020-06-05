# ConcursoProgram
Programa utilizado para revisar conteúdos de concurso. Visualizando os problemas existentes com o esquecimento de conteúdos para realizar provas de concurso, foi criado esse programa visando auxilar nas revisões dos conteúdos já estudados.


-------------------------------------------------------- CRIAÇÃO DO BANCO DE DADOS ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
Para iniciar o projeto é necessário criar um banco de dados MySQL. Uma forma simples de ser feita essa criação é: Utilizar do servidor Vertrigo, no qual a senha é root. Com isso, cria-se uma estrutura chamada calendário e uma tabela chamada concurso, e de acordo com o código abaixo o sistema irá funcionar:  

CREATE TABLE `calendario`.`Concurso` ( `NomedaDisciplina` VARCHAR(200) NOT NULL , `Arquivo` TEXT NOT NULL , `Categoria` VARCHAR(200) NOT NULL , `ID` INT(20) NOT NULL AUTO_INCREMENT , `Data` DATE NOT NULL , `Revisao` INT(20) NOT NULL , `Tempo` INT(20) NOT NULL , `DataRevisao` DATE NOT NULL , PRIMARY KEY (`ID`)) ENGINE = InnoDB;

O motivo de criar exatamente igual ao comando acima, é por que no código é passado exatamente esse comando para o software.

Se você desejar trabalhar com outro servidor é necessário alterar alterar as linhas iniciais do da ClassDB, a propriedade 'conectabanco' para o qual o servidor está presente.
Além desse ponto, no Form1.cs na linha 112 é necessário alterar o 'conectabanco'.

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

------------------------------------------------------------------ COMO UTILIZAR O PROGRAMA ---------------------------------------------------------------
O programa é dividido em 3 telas principais:
1. Tela principal (Form1): Nela é possível avaliar no calendário as datas em negrito, elas informam quando tem revisões para ser realizadas. Essa tela possui 3 botões principais:
             1. "Inserir Agendamento": Abre o outro form para cadastrar conteúdos para revisar.
             2. "Filtrar": É selecionado as datas no calendário e quando pressionado o botão é mostrado na caixa branca as especificações de todas as revisões daquela seleção.
             3. "Começar Revisão do Dia": Abre outro form que é possível executar as revisões diárias, pelo tempo calculado.
2. Tela de Salvamento (Form2): Nessa tela é salva as informações. É importante colocar o arquivo correto, pois ele será aberto em outro form.
3. Tela de Execução (OpenDocuments): Nessa é possível abrir o documento para revisar e iniciar o time, é interessante deixa o som ligado pois irá alertar quando acabar o tempo, então quando você terminar a tarefa pressionar o botão para concluir.
