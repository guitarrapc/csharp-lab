```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,338.0 ns** |    **276.43 ns** |    **15.15 ns** |     **1,327.1 ns** |     **1,355.3 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,469.0 ns |    102.87 ns |     5.64 ns |     1,465.1 ns |     1,475.5 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,692.4 ns |    162.51 ns |     8.91 ns |     1,684.9 ns |     1,702.3 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,629.2 ns |     83.56 ns |     4.58 ns |     2,626.5 ns |     2,634.5 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       207.5 ns |     33.86 ns |     1.86 ns |       205.6 ns |       209.3 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       289.8 ns |     53.83 ns |     2.95 ns |       286.6 ns |       292.4 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       485.0 ns |     30.87 ns |     1.69 ns |       483.6 ns |       486.9 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,545,635.0 ns** | **14,151.77 ns** |   **775.71 ns** | **1,545,047.4 ns** | **1,546,514.2 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,880.0 ns | 22,762.12 ns | 1,247.67 ns |   614,132.4 ns |   616,320.3 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   656,179.4 ns | 13,591.12 ns |   744.97 ns |   655,571.6 ns |   657,010.5 ns |      - |      69 B |
| SHA512Binary    | Byte[1048576]       | 1,374,260.2 ns | 43,974.60 ns | 2,410.40 ns | 1,372,810.9 ns | 1,377,042.7 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,553.5 ns |  6,048.28 ns |   331.53 ns |   162,267.9 ns |   162,917.0 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,415.4 ns |  1,560.80 ns |    85.55 ns |    91,331.0 ns |    91,502.1 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,557.2 ns |  9,557.27 ns |   523.87 ns |    65,205.9 ns |    66,159.3 ns |      - |      40 B |
