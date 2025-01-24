from dataclasses import dataclass


@dataclass
class PertNode: 
    task_name: str
    duration: int
    ef: int
    lf: int
    es: int
    ls: int

