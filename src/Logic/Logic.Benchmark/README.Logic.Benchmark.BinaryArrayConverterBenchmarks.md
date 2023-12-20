``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK=8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                       Method | Number |         Mean |      Error |    StdDev |          Min |          Max |  Gen 0 | Allocated |
|----------------------------- |------- |-------------:|-----------:|----------:|-------------:|-------------:|-------:|----------:|
|             **ToBinaryArrayInt** |      **1** |     **18.79 ns** |   **1.134 ns** |  **0.062 ns** |     **18.72 ns** |     **18.83 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString |      1 |     67.20 ns |   3.029 ns |  0.166 ns |     67.01 ns |     67.32 ns | 0.0011 |      96 B |
|          ToBinaryArrayIntMod |      1 |     21.14 ns |   1.808 ns |  0.099 ns |     21.07 ns |     21.25 ns | 0.0004 |      32 B |
|    ToBinaryArrayIntModNumber |      1 |     11.92 ns |   3.227 ns |  0.177 ns |     11.80 ns |     12.12 ns | 0.0004 |      32 B |
|             **ToBinaryArrayInt** |     **10** |    **190.17 ns** |  **38.232 ns** |  **2.096 ns** |    **187.76 ns** |    **191.57 ns** | **0.0038** |     **320 B** |
| ToBinaryArrayConvertToString |     10 |    683.13 ns |  49.586 ns |  2.718 ns |    680.30 ns |    685.72 ns | 0.0114 |   1,024 B |
|          ToBinaryArrayIntMod |     10 |    213.44 ns |  52.104 ns |  2.856 ns |    210.58 ns |    216.30 ns | 0.0038 |     320 B |
|    ToBinaryArrayIntModNumber |     10 |    158.11 ns |   7.862 ns |  0.431 ns |    157.82 ns |    158.60 ns | 0.0038 |     320 B |
|             **ToBinaryArrayInt** |    **100** |  **1,754.51 ns** |  **35.529 ns** |  **1.947 ns** |  **1,752.56 ns** |  **1,756.45 ns** | **0.0381** |   **3,200 B** |
| ToBinaryArrayConvertToString |    100 |  7,333.58 ns |  25.594 ns |  1.403 ns |  7,331.96 ns |  7,334.39 ns | 0.1297 |  10,928 B |
|          ToBinaryArrayIntMod |    100 |  2,064.01 ns | 172.952 ns |  9.480 ns |  2,058.30 ns |  2,074.96 ns | 0.0381 |   3,200 B |
|    ToBinaryArrayIntModNumber |    100 |  1,936.30 ns | 106.678 ns |  5.847 ns |  1,929.56 ns |  1,940.10 ns | 0.0381 |   3,200 B |
|             **ToBinaryArrayInt** |    **255** |  **4,498.48 ns** | **541.559 ns** | **29.685 ns** |  **4,467.43 ns** |  **4,526.58 ns** | **0.0916** |   **8,160 B** |
| ToBinaryArrayConvertToString |    255 | 17,354.76 ns | 723.786 ns | 39.673 ns | 17,313.00 ns | 17,391.95 ns | 0.2747 |  23,208 B |
|          ToBinaryArrayIntMod |    255 |  5,072.19 ns | 782.884 ns | 42.913 ns |  5,034.11 ns |  5,118.68 ns | 0.0916 |   8,160 B |
|    ToBinaryArrayIntModNumber |    255 |  5,029.77 ns | 288.227 ns | 15.799 ns |  5,017.47 ns |  5,047.58 ns | 0.0916 |   8,160 B |
