```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean        | Error        | StdDev     | Min         | Max         | Gen0   | Allocated |
|------------------------------------------- |------- |------------:|-------------:|-----------:|------------:|------------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |    **59.43 ns** |     **4.562 ns** |   **0.250 ns** |    **59.22 ns** |    **59.71 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |    59.67 ns |    27.062 ns |   1.483 ns |    58.74 ns |    61.38 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |    64.68 ns |     3.218 ns |   0.176 ns |    64.52 ns |    64.87 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |    19.87 ns |     2.101 ns |   0.115 ns |    19.77 ns |    20.00 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |    19.88 ns |     1.059 ns |   0.058 ns |    19.83 ns |    19.95 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |    19.36 ns |     2.468 ns |   0.135 ns |    19.21 ns |    19.45 ns |      - |         - |
| **LogWithoutIfParams**                         | **10**     |   **602.91 ns** |     **4.861 ns** |   **0.266 ns** |   **602.70 ns** |   **603.21 ns** | **0.0105** |     **880 B** |
| LogWithIfParams                            | 10     |   645.44 ns |    97.862 ns |   5.364 ns |   640.70 ns |   651.27 ns | 0.0105 |     880 B |
| LogAdapterWithoutIfParams                  | 10     |   654.52 ns |    40.238 ns |   2.206 ns |   652.76 ns |   657.00 ns | 0.0105 |     880 B |
| LogDefineWithoutIfParams                   | 10     |   197.95 ns |     1.325 ns |   0.073 ns |   197.88 ns |   198.02 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 10     |   197.30 ns |     0.696 ns |   0.038 ns |   197.26 ns |   197.34 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 10     |   192.26 ns |     6.544 ns |   0.359 ns |   191.92 ns |   192.63 ns |      - |         - |
| **LogWithoutIfParams**                         | **100**    | **6,019.94 ns** |   **431.759 ns** |  **23.666 ns** | **5,995.57 ns** | **6,042.83 ns** | **0.0992** |    **8800 B** |
| LogWithIfParams                            | 100    | 6,022.72 ns | 3,615.394 ns | 198.172 ns | 5,888.46 ns | 6,250.33 ns | 0.0992 |    8800 B |
| LogAdapterWithoutIfParams                  | 100    | 6,594.12 ns |   227.773 ns |  12.485 ns | 6,581.52 ns | 6,606.49 ns | 0.0992 |    8800 B |
| LogDefineWithoutIfParams                   | 100    | 1,992.18 ns |   137.939 ns |   7.561 ns | 1,985.42 ns | 2,000.34 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 100    | 1,997.22 ns |   177.153 ns |   9.710 ns | 1,989.32 ns | 2,008.06 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 100    | 1,943.56 ns |    57.548 ns |   3.154 ns | 1,941.61 ns | 1,947.20 ns |      - |         - |
