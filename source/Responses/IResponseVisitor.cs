using System;

namespace AmaruCommon.Responses
{
    public interface IResponseVisitor
    {
        void Visit(NewTurnResponse response);
        void Visit(MainTurnResponse mainTurnResponse);
        void Visit(PlayACreatureResponse playACreatureResponse);
        void Visit(PlayASpellResponse playASpellResponse);
        void Visit(DrawCardResponse drawCardResponse);
        void Visit(GameFinishedResponse gameFinishedResponse);
        void Visit(PlayerKilledResponse playerKilledResponse);
        void Visit(GraveyardChangedResponse graveyardChangedResponse);
        void Visit(CardsModifiedResponse cardsModifiedResponse);
        void Visit(PlayerModifiedResponse playerModifiedResponse);
        void Visit(MoveCreatureResponse moveCreatureResponse);
        void Visit(AttackCreatureResponse attackCreatureResponse);
        void Visit(AttackPlayerResponse attackPlayerResponse);
    }
}
