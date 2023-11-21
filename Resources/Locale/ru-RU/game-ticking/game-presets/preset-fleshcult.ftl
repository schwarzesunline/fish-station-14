flesh-cult = Культ Плоти
objective-issuer-flesh-cult = [color=#801818]Культ Плоти[/color]
flesh-cult-round-end-result =
    { $cultistsCount ->
    [one] Был один культист плоти.
    *[other] Было { $cultistsCount } культистов плоти.
    }
flesh-cult-round-end-cultist-live-amount-none = [color=green]Все культисты были уничтожены![/color]
flesh-cult-round-end-cultist-live-amount-low = [color=green]Почти все культисты были уничтожены.[/color]
flesh-cult-round-end-flesh-heart-succes = [color=green]Станция превратилась в царство плоти![/color]
flesh-cult-round-end-flesh-heart-fail = [color=red]Культ Плоти не смог достичь своей цели![/color]
flesh-cult-user-was-a-cultist = [color=gray]{ $user }[/color] был культистом плоти.
flesh-cult-user-was-a-traitor-named = [color=White]{ $name }[/color] ([color=gray]{ $user }[/color]) был культистом плоти.
flesh-cult-was-a-traitor-named = [color=White]{ $name }[/color] был культистом плоти.

flesh-cult-user-was-a-cultist-leader = [color=gray]{ $user }[/color] был лидером Культа Плоти.
flesh-cult-user-was-a-cultist-leader-named = [color=White]{ $name }[/color] ([color=gray]{ $user }[/color]) был лидером Культа Плоти.
flesh-cult-was-a-cultist-leader-named = [color=White]{ $name }[/color] был лидером Культа Плоти.

flesh-cult-user-was-a-cultist-with-objectives = [color=gray]{ $user }[/color] был культистом плоти со следующими целями:
flesh-cult-user-was-a-cultist-with-objectives-named = [color=White]{ $name }[/color] ([color=gray]{ $user }[/color]) был культистом плоти со следующими целями:
flesh-cult-was-a-cultist-with-objectives-named = [color=White]{ $name }[/color] был культистом плоти со следующими целями:

flesh-cult-user-was-a-cultist-leader-with-objectives = [color=gray]{ $user }[/color] был лидером Культа Плоти со следующими целями:
flesh-cult-user-was-a-cultist-leader-with-objectives-named = [color=White]{ $name }[/color] ([color=gray]{ $user }[/color]) был лидером Культа Плоти со следующими целями:
flesh-cult-was-a-cultist-leader-with-objectives-named = [color=White]{ $name }[/color] был лидером Культа Плоти со следующими целями:

preset-flesh-cult-objective-issuer-flesh-cult = [color=#e0106a]Культ плоти[/color]
flesh-cult-objective-condition-success = { $condition } | [color={ $markupColor }]Успех![/color]
flesh-cult-objective-condition-fail = { $condition } | [color={ $markupColor }]Провал![/color] ({ $progress }%)
flesh-cult-title = Культ Плоти
flesh-cult-description = На станции возник культ, стремящийся взять под контроль.
flesh-cult-not-enough-ready-players = Недостаточное количество игроков готовы играть! Из необходимых игроков { $minimumPlayers } готовы только { $readyPlayersCount }.
flesh-cult-no-one-ready = Ни один игрок не готов! Не удалось запустить игровой режим Культ Плоти.

flesh-cult-role-greeting = Вы являетесь членом Культа Плоти.
     Ваши цели и коллеги-культисты указаны в меню персонажа.
     Пожирайте существ из плоти, чтобы получить новые способности, оставаться в тени и готовиться к прибытию Плоти на станцию. Связь с другими культистами - .а
flesh-cult-role-cult-members = Ваши коллеги-культисты:
    { $cultMembers }
    Не позволяйте им умереть напрасно.

flesh-cult-role-greeting-leader = Вы лидер Культа Плоти.
     Ваши цели и коллеги-культисты указаны в меню персонажа.
     Пожирайте существ из плоти, чтобы получить новые способности, оставаться в тени и готовиться к прибытию Плоти на станцию. Связь с другими культистами - .а
     Следите за тем, чтобы ни один из членов вашего культа не погиб напрасно.
ent-CreateFleshHeartObjective = Создай и пробуди сердце плоти.
    .desc =
        Вам нужно развить необходимый навык, чтобы создать сердце.
        Чтобы пробудить его, оно должно поглотить необходимое количество тел эволюционировавших существ.
        После пробуждения будьте готовы защищать его, так как он начнет превращать всю станцию в плоть.
ent-FleshCultistSurvivalObjective = Выжить и сохранить человеческий облик.
    .desc = Избегайте голода паразита, чтобы предотвратить непредвиденные обстоятельства.