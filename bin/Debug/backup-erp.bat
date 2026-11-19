echo Makrosoft : gerando backup...

set nomeArquivo=%6\bkp_mt%date:/=-%-%time:~0,2%-%time:~3,2%-%time:~6,2%.sql

cd %~1

mysqldump.exe --user=%2 --password=%3 --max_allowed_packet=1G --host=%4 --port=%5 --default-character-set=utf8 --routines "bd_erp" > %6%

echo Makrosoft : backup gerado com sucesso
