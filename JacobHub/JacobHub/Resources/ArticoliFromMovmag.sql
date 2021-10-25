select mm_codart, 
mm_descr, 
mm_quant,
(select top 1 bc_code from barcode where bc_codart = mm_codart ) as Barcode, 
isnull((select lc_prezzo from listini where lc_codart = mm_codart and lc_listino = 2),0) as prezzo,
isnull((select so_scont1 from sconti where so_codart = mm_codart and so_clscan = 2),0)  as sc1,
isnull((select so_scont2 from sconti where so_codart = mm_codart and so_clscan = 2),0)  as sc2,
0 et1,
0 et2,
0 et3,
0 et4
from movmag
where mm_tipork = 'B' and concat( mm_numdoc, '/', mm_serie, '/', mm_anno) = @ddt
order by mm_codart asc