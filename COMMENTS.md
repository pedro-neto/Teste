Desenvolvimento da Api CRUD:
    Foi utilizado uma abordagem simples de api com documentação via swagger.
    BackEnd:
        Pontos de melhoria:
            Devido a complexidade baixa da api não tem outras. Exemplo: DOMAIN e DATA
            A regra de negocio deve ser separada da controller, as operações CRUD foram geradas com EntityFrameworkCore.Design, precisando apenas de alguns ajustes.
            Com a camada de Domain posso separar toda a parte de negocio da apicação visãndo um crecimento.
            A camada de DATA pode deve ficar em um projeto separado tambem.
    FrontEnd:
        Pontos a melhorar:
            Não consegui fazer a integração com o back-end
            Apenas o visual.      