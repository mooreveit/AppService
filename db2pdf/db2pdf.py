# extrae data sql - > pdf
#
# SE REQUIERE:
#    1) instalar pyodbc (pip install pyodbc)
#
#    2) añadir campo Ruta(varchar(150)) a la tabla: 'CobAdjuntosCobranza'
#-----------------------------------------------------------------------------

import pyodbc

#************************************************************

# PARAMETROS  

# CADENA DE COMEXION
conn = pyodbc.connect('Driver={SQL Server};'
                        'Server=.;'
                        'Database=RRD;'
                        'Trusted_Connection=yes;')

# RUTA ARCHIVOS DE SALIDA
FILE_PATH = 'D:/proyectos/Proyectos2020/MOORE/'
  
#TABLA FUENTE DE DATPOS
TB_NAME = 'CobAdjuntosCobranza'


REGISTROS_POR_SEGMENTO = 5
#************************************************************

print('INICIANDO')

cursor = conn.cursor()

#inicializa campo ruta
print('INICIALIZANDO CAMPO RUTA...')
cursor.execute( "update " + TB_NAME + " set Ruta=''")     # + "WHERE RUTA=''"
conn.commit()
cursor.close()
print('INICIALIZADO CAMPO RUTA...')

#cursor
cursor = conn.cursor()

#cuento los registros a procesar
cursor.execute("select count(*) from " + TB_NAME)
result = cursor.fetchone()
totalregistros = result[0]

contadorregistros = 0

hacer=True

print('EXPORTANDO ARCHIVOS...')

while hacer:
    
    print("")
    
    #obtiene segmento de registros a procesar   
    cursor.execute( "select top " + str(REGISTROS_POR_SEGMENTO) + " * from " + TB_NAME + " WHERE Ruta=''")   
    rows = cursor.fetchall()
    
    #crea los archivos correspondientes al segmento
    for row in rows:
            
        fname = (FILE_PATH + row.NombreArchivo).lower()
        
        with open(fname, "wb") as output_file:
        
            output_file.write(row.Archivo)
                     
        #actualiza la ruta para el registro en proceso    
        cursor.execute("UPDATE dbo.CobAdjuntosCobranza  SET ruta=? WHERE IdAdjunto=?", (FILE_PATH, row.IdAdjunto))
        conn.commit()
      
        contadorregistros = contadorregistros + 1        
               
        print(contadorregistros, fname)
        
    #comprueba final de proceso para salir del bucle
    if(contadorregistros == totalregistros): hacer=False
  
    
print('***** EXPORTACION FINALIZADA *****')