# -*- mode: python ; coding: utf-8 -*-

block_cipher = None


a = Analysis(['instance_test.py'],
             pathex=['C:\\Users\\user\\Desktop\\bilgisayar stuff\\Civan_AI_UI\\Civan_AI_UI\\core'],
             binaries=[],
             datas=[('ANN_heart_disease.model', '.'), ('CNN_covid_pred.model', '.'), ('C:/Civan/db.civan', '.'), ('C:/Civan/res.civan', '.')],
             hiddenimports=['tensorflow', 'tensorflow.lite.python.lite', 'pkg_resources.py2_warn'],
             hookspath=[],
             runtime_hooks=[],
             excludes=[],
             win_no_prefer_redirects=False,
             win_private_assemblies=False,
             cipher=block_cipher,
             noarchive=False)
pyz = PYZ(a.pure, a.zipped_data,
             cipher=block_cipher)
exe = EXE(pyz,
          a.scripts,
          a.binaries,
          a.zipfiles,
          a.datas,
          [],
          name='instance_test',
          debug=False,
          bootloader_ignore_signals=False,
          strip=False,
          upx=True,
          upx_exclude=[],
          runtime_tmpdir=None,
          console=True )
