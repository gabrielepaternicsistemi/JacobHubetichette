select 
	ar_codart, 
	ar_descr, 
	bc_code, 
	qta,
	isnull((select lc_prezzo from listini where lc_codart = ar_codart and lc_listino = 2 and lc_conto = 0),0) as prezzo,
  isnull((select  so_scont1 from sconti where so_codart = ar_codart and so_conto = 0 and so_clscan = 2),0) as sconto1,
  isnull((select  so_scont2 from sconti where so_codart = ar_codart and so_conto = 0 and so_clscan = 2),0) as sconto2
from artico 
	inner join barcode on ar_codart = bc_codart 
	inner join hhTmpCsv on barcode = bc_code
order by id