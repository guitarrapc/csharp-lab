```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,305.2 ns** |     **67.30 ns** |     **3.69 ns** |     **1,301.3 ns** |     **1,308.6 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,441.4 ns |     64.11 ns |     3.51 ns |     1,437.4 ns |     1,443.8 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,673.5 ns |     49.16 ns |     2.69 ns |     1,671.6 ns |     1,676.6 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,685.5 ns |    426.55 ns |    23.38 ns |     2,661.6 ns |     2,708.3 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       202.5 ns |     38.67 ns |     2.12 ns |       200.6 ns |       204.8 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       286.2 ns |     31.73 ns |     1.74 ns |       284.2 ns |       287.5 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       516.0 ns |     17.03 ns |     0.93 ns |       514.9 ns |       516.8 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,545,577.6 ns** |  **6,309.43 ns** |   **345.84 ns** | **1,545,288.0 ns** | **1,545,960.5 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,319.7 ns |  1,733.51 ns |    95.02 ns |   614,210.2 ns |   614,380.7 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   657,678.9 ns | 42,790.58 ns | 2,345.50 ns |   654,970.6 ns |   659,051.8 ns |      - |      69 B |
| SHA512Binary    | Byte[1048576]       | 1,372,581.5 ns |  7,159.63 ns |   392.44 ns | 1,372,232.9 ns | 1,373,006.6 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,518.2 ns |  6,994.03 ns |   383.37 ns |   162,268.2 ns |   162,959.6 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    92,009.6 ns | 16,264.38 ns |   891.51 ns |    91,482.2 ns |    93,038.9 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    64,996.4 ns |    471.73 ns |    25.86 ns |    64,969.9 ns |    65,021.6 ns |      - |      40 B |
